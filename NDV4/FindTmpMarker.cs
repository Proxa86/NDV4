using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace NDV4
{
    class FindTmpMarker
    {
        public SQLiteConnection DbConn { get; set; }

        public SQLiteCommand SqlCmd { get; set; }

        public static Label label { get; set; }

        public FindTmpMarker() 
        {
            
        }

        public FindTmpMarker(Label l)
        {
            DbConn = InfoOpenProject.DbConn;
            SqlCmd = InfoOpenProject.SqlCmd;
            label = l;
        }

        public void findTmpMarkerWithBin()
        {
            List<string[]> lParentFilters = new List<string[]>(); 
            string pathFolderBin = InfoOpenProject.PathLocation + "\\Lab\\Bin";

            lParentFilters.Add(Directory.GetFiles(pathFolderBin, "*", SearchOption.AllDirectories));

            if (!Directory.EnumerateFiles(pathFolderBin, "*.*", SearchOption.AllDirectories).Any())
            {
                MessageBox.Show("Folder Src/Bin is empty!");
            }

            try
            {
                if(Form1.CheckClearResultBin)
                {
                    SqlCmd.CommandText = @"DELETE FROM BinMarker";
                    SqlCmd.ExecuteNonQuery();
                    SqlCmd.CommandText = @"DELETE FROM BinName";
                    SqlCmd.ExecuteNonQuery();
                    SqlCmd.CommandText = @"UPDATE WorkMarker SET markerInBin = NULL";
                    SqlCmd.ExecuteNonQuery();
                }
                

                using (SQLiteTransaction transation = SqlCmd.Connection.BeginTransaction())
                {
                    foreach (var filter in lParentFilters)
                    {
                        int i = 1;
                        foreach (var pathBin in filter)
                        {
                            label.Text = "Analysis binary ( " + i + " / " + filter.Length + " )";
                            label.Refresh();
                            //string[] allLinesInFile = File.ReadAllLines(pathBin);

                            string allText = File.ReadAllText(pathBin);

                            SqlCmd.CommandText = @"INSERT INTO BinName 
                                            (idBin,
                                            nameBin, 
                                            pathBin
                                            ) 
                                            VALUES 
                                            ($idBin,
                                            $nameBin, 
                                            $pathBin 
                                            )";

                            SqlCmd.Parameters.AddWithValue("$idBin", i);
                            SqlCmd.Parameters.AddWithValue("$nameBin", Path.GetFileName(pathBin));
                            SqlCmd.Parameters.AddWithValue("$pathBin", pathBin);

                            SqlCmd.ExecuteNonQuery();

                            //foreach (var line in allLinesInFile)
                            //{
                            string paternFindTmpMarker = "tmp[0-9]{8}";

                            Regex regex = new Regex(paternFindTmpMarker, RegexOptions.Compiled);
                            //MatchCollection matches = regex.Matches(line);
                            IEnumerable<string> en = Regex.Matches(allText, paternFindTmpMarker).OfType<Match>().Select(m => m.Groups[0].Value).Distinct();
                            if(en.Count() > 0)
                            {
                                foreach(var marker in en)
                                {

                                    SqlCmd.CommandText = @"UPDATE WorkMarker SET markerInBin = $markerInBin WHERE marker = $marker";
                                    SqlCmd.Parameters.AddWithValue("$markerInBin", "1");
                                    SqlCmd.Parameters.AddWithValue("$marker", marker);

                                    SqlCmd.ExecuteNonQuery();

                                    SqlCmd.CommandText = @"INSERT INTO BinMarker 
                                                (idBin,
                                                markerBin
                                                ) 
                                                VALUES 
                                                ($idBin,
                                                $markerBin
                                                )";

                                    SqlCmd.Parameters.AddWithValue("$idBin", i);
                                    SqlCmd.Parameters.AddWithValue("$markerBin", marker);

                                    SqlCmd.ExecuteNonQuery();
                                }
                            }


                            //Regex regex = new Regex(paternFindTmpMarker);
                            //Match match = regex.Match(line);

                            //while (match.Success)
                            //{
                            //    string marker = match.Value;

                            //    SqlCmd.CommandText = @"UPDATE WorkMarker SET markerInBin = $markerInBin WHERE marker = $marker";
                            //    SqlCmd.Parameters.AddWithValue("$markerInBin", "1");
                            //    SqlCmd.Parameters.AddWithValue("$marker", marker);

                            //    SqlCmd.ExecuteNonQuery();

                            //    SqlCmd.CommandText = @"INSERT INTO BinMarker 
                            //            (idBin,
                            //            markerBin
                            //            ) 
                            //            VALUES 
                            //            ($idBin,
                            //            $markerBin
                            //            )";

                            //    SqlCmd.Parameters.AddWithValue("$idBin", i);
                            //    SqlCmd.Parameters.AddWithValue("$markerBin", marker);

                            //    SqlCmd.ExecuteNonQuery();

                            //    match = match.NextMatch(); // ищем следующее совпадение в текущей строке                       
                            //}
                            //}
                            
                            ++i;
                            
                        }
                        
                    }
                    transation.Commit();
                }

                //MessageBox.Show("Analisys end!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't open file.\nOriginal error: " + e.Message);
            }   
        }
    }
}
