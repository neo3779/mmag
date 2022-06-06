using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace London2012
{
    public class EventInfo
    {
        private string[,] array;

        private int numberItems;

        public int NumberItems
        {
            get { return numberItems - 1; }
        }

        public EventInfo()
        {
            numberItems = 20;
            array = new string[numberItems, 4];
            array[0, 0] = "25/07/2012"; array[0, 1] = "Football"; array[0, 2] = "Millennium Stadium, Cardiff"; array[0, 3] = "16:00 - 20:40";
            array[1, 0] = "25/07/2012"; array[1, 1] = "Football"; array[1, 2] = "City of Coventry Stadium, Coventry"; array[1, 3] = "17:00 - 21:45";
            array[2, 0] = "25/07/2012"; array[2, 1] = "Football"; array[2, 2] = "Hampden Park, Glasgow"; array[2, 3] = "17:00 - 21:45";
            array[3, 0] = "26/07/2012"; array[3, 1] = "Football"; array[3, 2] = "Hampden Park, Glasgow"; array[3, 3] = "12:00 - 16:45";
            array[4, 0] = "26/07/2012"; array[4, 1] = "Football"; array[4, 2] = "St James' Park, Newcastle"; array[4, 3] = "16:30 - 19:15";
            array[5, 0] = "26/07/2012"; array[5, 1] = "Football"; array[5, 2] = "Old Trafford, Manchester"; array[5, 3] = "16:00 - 20:40";
            array[6, 0] = "26/07/2012"; array[6, 1] = "Football"; array[6, 2] = "Millennium Stadium, Cardiff"; array[6, 3] = "16:00 - 20:40";
            array[7, 0] = "26/07/2012"; array[7, 1] = "Football"; array[7, 2] = "City of Coventry Stadium, Coventry"; array[7, 3] = "16:00 - 20:40";
            array[8, 0] = "27/07/2012"; array[8, 1] = "Archery"; array[8, 2] = "Lord's Cricket Ground"; array[8, 3] = "16:00 - 20:40";
            array[9, 0] = "27/07/2012"; array[9, 1] = "Archery"; array[9, 2] = "Lord's Cricket Ground"; array[9, 3] = "16:00 - 20:40";
            array[10, 0] = "27/07/2012"; array[10, 1] = "Opening Ceremony"; array[10, 2] = "Olympic Park - Olympic Stadium"; array[10, 3] = "16:00 - 20:40";
            array[11, 0] = "28/07/2012"; array[11, 1] = "Shooting"; array[11, 2] = "The Royal Artillery Barracks"; array[11, 3] = "16:00 - 20:40";
            array[12, 0] = "28/07/2012"; array[12, 1] = "Badminton"; array[12, 2] = "Wembley Arena"; array[12, 3] = "16:00 - 20:40";
            array[13, 0] = "28/07/2012"; array[13, 1] = "Basketball"; array[13, 2] = "Olympic Park - Basketball Arena"; array[13, 3] = "16:00 - 20:40";
            array[14, 0] = "28/07/2012"; array[14, 1] = "Judo"; array[14, 2] = "Eton Dorney, Buckinghamshire"; array[14, 3] = "16:00 - 20:40";
            array[15, 0] = "28/07/2012"; array[15, 1] = "Archery"; array[15, 2] = "Horse Guards Parade"; array[15, 3] = "16:00 - 20:40";
            array[16, 0] = "28/07/2012"; array[16, 1] = "Beach Volleyball"; array[16, 2] = "ExCeL"; array[16, 3] = "16:00 - 20:40";
            array[17, 0] = "28/07/2012"; array[17, 1] = "Table Tennis"; array[17, 2] = "ExCeL"; array[17, 3] = "16:00 - 20:40";
            array[18, 0] = "28/07/2012"; array[18, 1] = "Judo"; array[18, 2] = "Eton Dorney, Buckinghamshire"; array[18, 3] = "16:00 - 20:40";
            array[19, 0] = "28/07/2012"; array[19, 1] = "Rowing"; array[19, 2] = "Earls Court"; array[19, 3] = "16:00 - 20:40";


        }

        public string [] GetDates()
        {
            List<string> dates = new List<string>();
            for (int i = 0; i < numberItems - 1; i++)
            {
                if(!dates.Contains(array[i,0]))

                {
                    dates.Add(array[i, 0]);
                }
            }
            return dates.ToArray();
        }

        public string[] GetEvents()
        {
            List<string> dates = new List<string>();
            for (int i = 0; i < numberItems - 1; i++)
            {
                if (!dates.Contains(array[i, 1]))
                {
                    dates.Add(array[i, 1]);
                }
            }
            return dates.ToArray();
        }

        public string[] GetVenue()
        {
            List<string> dates = new List<string>();
            for (int i = 0; i < numberItems - 1; i++)
            {
                if (!dates.Contains(array[i, 2]))
                {
                    dates.Add(array[i, 2]);
                }
            }
            return dates.ToArray();
        }

        public string[,] Search(string date, string evnt, string venue)
        {
            string[,] results;
            results = new string[20,4];
            int index = 0;

            for(int i = 0; i< numberItems; i++)
            {
                if(array[i, 0].Equals(date)||date=="Any Date")
                {
                    if(array[i,1].Equals(evnt)||evnt=="Any Event")
                    {
                        if(array[i,2].Equals(venue)||venue=="Any Venue")
                        {
                            results[index, 0] = array[i,0];
                            results[index, 1] = array[i, 1];
                            results[index, 2] = array[i, 2];
                            results[index, 3] = array[i, 3];
                            index++;
                        }
                    }
                }
            }
            return results;
        }
    }
}
