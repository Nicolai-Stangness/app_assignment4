using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            sensor sensor_1 = new sensor(25, 66, 133, 1);
            Console.WriteLine("sensor_1:: temp = {0}", sensor_1.read_temp());

            sensor sensor_2 = new sensor(20, 33, 300, 1);

            Console.WriteLine("sensor_2:: temp = {0}", sensor_2.read_temp());

            sensor sum = sensor_1 + sensor_2;
            sensor diff = sensor_1 - sensor_2;
            sensor_1 = sensor_1++;

            sensor divisor = new sensor(2, 2, 2, 2);
            sensor average = sum / divisor;

            Console.WriteLine("sum of temp is {0}, average of co2 is {1}", sum.read_temp(),average.read_co2());
            Console.WriteLine("difference of temp is {0}", diff.read_temp());

            sensor_1 = sensor_1++;

            Console.WriteLine("count is at {0}, abd temp is at {1}", sensor_1.read_count(),sensor_1.read_temp());
            sensor_1 = sensor_1--;
            Console.WriteLine("oh wait, that's one too many counts count is really at {0}", sensor_1.read_count());
            Console.ReadKey();
        }
    }
    class sensor
    {
        private float temp;
        private double rel_hum;
        private int CO2_con;
        private string model_id;
        private int count;

        public sensor()
        {
            temp = -555;
            rel_hum = -555;
            CO2_con = -555;
            model_id = "abc";

        }
        public double read_hum()
        {
            return rel_hum;
        }
        public float read_temp()
        {
            return temp;
        }
        public int read_co2()
        {
            return CO2_con;
        }
        public int read_count()
        {
            return count;
        }
        public void write_hum(double hum1)
        {
            rel_hum = hum1;
        }
        public void write_temp(float temp1)
        {
            temp = temp1;
        }
        public void write_co2(int co2)
        {
            CO2_con = co2;
        }

        public void write_count(int count1)
        {
            count = count1;
        }
        //overloaded constructor
        public sensor(float temp1, double hum1, int co2, int count1)
        {
            temp = temp1;
            rel_hum = hum1;
            CO2_con = co2;
            count = count1;

        }
        public static sensor operator +(sensor left, sensor right)
        {
            sensor sum = new sensor(0, 0, 0, 0);
            sum.temp = (left.temp + right.temp);
            sum.rel_hum = (left.rel_hum + right.rel_hum);
            sum.CO2_con = (left.CO2_con + right.CO2_con);
            sum.count = (left.count + right.count);
            return sum;
        }

        public static sensor operator -(sensor left, sensor right)
        {
            sensor diff = new sensor(0, 0, 0, 0);
            diff.temp = left.temp - right.temp;
            diff.rel_hum = left.rel_hum - right.rel_hum;
            diff.CO2_con = left.CO2_con - right.CO2_con;
            diff.count = left.count - right.count;
            return diff;
        }

        public static sensor operator /(sensor divident, sensor divisor)
        {
            sensor result = new sensor(0, 0, 0, 0);
            result.temp = divident.temp / divisor.temp;
            result.rel_hum = divident.rel_hum / divisor.rel_hum;
            result.CO2_con = divident.CO2_con / divisor.CO2_con;
            result.count = divident.count / divisor.count;
            return result;
        }
        public static sensor operator ++(sensor iter)
        {
            //iter.temp +=  1;
            //iter.rel_hum +=  1;
            //iter.CO2_con +=  1;
            iter.count +=  1;

            return iter;
        }

        public static sensor operator --(sensor iter)
        {
            //iter.temp +=  1;
            //iter.rel_hum +=  1;
            //iter.CO2_con +=  1;
            iter.count -= 1;

            return iter;
        }
    }
}
