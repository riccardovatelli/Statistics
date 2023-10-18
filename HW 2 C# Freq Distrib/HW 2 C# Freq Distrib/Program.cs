using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_C__Freq_Distrib
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\Riccardo\source\repos\Professional Life - Sheet2.csv";
            StreamReader reader = null;
            List<string> csvLines = new List<string>();

            // Scorre e legge intero file .xlsx, aggiunge righe a lista csvLines
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach (var item in values)
                    {
                        csvLines.Add(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Errore");
            }

            FrequencyDist<string> cs = new FrequencyDist<string>(csvLines);
            decimal tot_count = 0;
            decimal rel_freq = 0;

            foreach (var v in cs.ItemFreq.Values)
            {
                Console.WriteLine($"Val: {v.value}" + ", " + $"Abs Freq: {v.count}");
                tot_count += v.count;
            }
            Console.WriteLine($"\nTot count {tot_count}\n");
            foreach (var v in cs.ItemFreq.Values)
            {
                rel_freq = v.count / tot_count;
                int pct = (int)Math.Round((decimal)(100 * v.count) / tot_count);
                Console.WriteLine($"Relative frequency of value {v.value} : {rel_freq}");
                Console.WriteLine($"{pct}%\n");
            }

            JointDistrib(cs, "Ambitious (0-5)", "Team leader or Team player ?", tot_count);
            Console.ReadLine();
        }


        static void JointDistrib(FrequencyDist<string> csv, string v1, string v2, decimal tot_count)
        {
            var joint = new Dictionary<string, int>();
            string valV1, valV2;

            foreach (var itemFreq in csv.ItemFreq.Values) {
                valV1 = v1;
                //Console.WriteLine($"\n (v1, itemFreq.Value): {(v1, itemFreq.Value)}");
                valV2 = v2;
                //Console.WriteLine($"\n (v2, itemFreq.Value): {(v2, itemFreq.Value)}");

                var k = $"({valV1}, {valV2})";

                if (joint.ContainsKey(k)) {
                    joint[k]++;
                }
                else {
                    joint[k] = 1;
                }
            }

            Console.WriteLine($"\nJoint Distribution of values: ({v1}, {v2})");
            Console.WriteLine("\nBiv Abs Freq    Biv Rel Freq    BivPct");

            foreach (var key in joint.Keys)
            {
                var absFreq = joint[key];
                var relFreq = (decimal)absFreq / tot_count;
                var pct = (relFreq*100);
                Console.WriteLine($"{absFreq}\t\t{relFreq:F2}\t\t{pct}%");
            }
        }


        public class FrequencyDist<T>
        {
            public FrequencyDist(List<T> csvLines)
            {
                CalcFreqDist(csvLines);
            }

            public FrequencyDist(List<T> csvLines, List<T> itemValues)
            {
                CalcFreqDist(csvLines);
                foreach (var v in itemValues)
                {
                    if (!ItemFreq.Keys.Contains(v))
                    {
                        ItemFreq.Add(v, new Item { value = v, count = 0 });
                    }
                }

                foreach (var v in csvLines)
                {
                    if (!itemValues.Contains(v))
                        throw new Exception(string.Format("Valore non trovato: '{0}'.", v));
                }
            }


            void CalcFreqDist(List<T> csvLines)
            {
                itemFreq = new SortedList<T, Item>((from item in csvLines
                                                    group item by item into theGroup
                                                    select new Item { value = theGroup.FirstOrDefault(), count = theGroup.Count() }).ToDictionary(q => q.value, q => q));
            }
            SortedList<T, Item> itemFreq = new SortedList<T, Item>();


            public SortedList<T, Item> ItemFreq { get { return itemFreq; } }


            public decimal Freq(T value)
            {
                if (itemFreq.Keys.Contains(value))
                {
                    return itemFreq[value].count;
                }
                else
                {
                    return 0;
                }
            }

            public static List<T> GetDistinctValues(List<T> l1, List<T> l2)
            {
                return l1.Concat(l2).ToList().Distinct().ToList();
            }

            public class Item
            {
                public T value { get; set; }
                public decimal count { get; set; }
            }
        }
    }
}
