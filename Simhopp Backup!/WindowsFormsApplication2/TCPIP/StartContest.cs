using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClassLibrary1;

namespace WindowsFormsApplication2.Klasser
{
    public class StartContest
    {
        public StartContest()
        {
        }

        public int gogogo(HandleTcpClient.TcpServer tcpServerObj, Contest contestObj, string infoStringforJudges, string PointString, int contestfinished)
        {
            int j = 0;
            
                if (tcpServerObj.ListHandleTcpClients.Count == 3)
                {
                    try
                    {
                        foreach (var x in contestObj.ContenderList)
                        {
                            for (int i = 0; i < contestObj.ContenderList.Count; i++)
                            {
                                infoStringforJudges = (contestObj.ContenderList[i].Name + " " + contestObj.ContenderList[i].Nationality + " " + contestObj.ContenderList[i].ListJumps[j].Jumpstyle);
                                tcpServerObj.SendToAllClients(infoStringforJudges);
                                lock (tcpServerObj.ListHandleTcpClients)
                                {
                                    foreach (var judge in tcpServerObj.ListHandleTcpClients)
                                    {
                                        PointString = String.Empty;
                                        PointString = judge.StreamReader.ReadLine();
                                        Console.WriteLine(PointString);
                                        contestObj.ContenderList[i].ListJumps[j].Point += double.Parse(PointString, System.Globalization.NumberStyles.AllowDecimalPoint);
                                    }
                                }
                                contestObj.ContenderList[i].ListJumps[j].Point *= contestObj.ContenderList[i].ListJumps[j].jumpDifficulty; //Gångrar antalet poäng från judges med hoppets svårighetsgrad.
                            }
                            j++;
                        }
                       
                    
                        foreach (var item in contestObj.ContenderList)    //// mio cambie a commentario ambos foreach loops
                        {
                            item.summeraPoints();
                        }
                        foreach (var item in contestObj.ContenderList)
                        {
                            Console.WriteLine(item.Name + " " + item.totalPoints);
                        }
                    tcpServerObj.SendToAllClients("Vinnare! : " + contestObj.find_winner() + ": " + contestObj.find_winners_score() + "p");


                   
                    tcpServerObj.SendToAllClients("quit");
                        
                    }
                    catch (Exception excep)
                    {
                        Console.WriteLine(excep);
                    }
                    finally
                    {
                        Thread.Sleep(5000);
                        tcpServerObj.KillThreads();
                    }
                    return contestfinished = 1;
                }
                else
                {
                    return 0;
                }

            }
        }
        }
    

