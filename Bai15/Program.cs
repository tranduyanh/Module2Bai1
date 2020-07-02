using System;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=2;
            int dem=0;
            while(dem!=20)
            {
                bool check1=true;
                for(int j=2;j<i;j++){
                    if(i%j==0){
                        check1=false;
                        break;
                    }
                }
                if(check1){
                    Console.WriteLine(i);
                    dem++;
                }
                i++;
            }
        }
    }
}
