namespace Lesson02_Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////C1
            //int soDien = 12;
            //float tongTien;
            //if(soDien <= 30)
            //{
            //    tongTien = 30;
            //}else if (soDien <= 50 && soDien > 30)
            //{
            //    tongTien = 30 + (soDien-30) * 1.2f;
            //}
            //else 
            //{
            //    tongTien = 30 + (50 - 30) * 1.2f + (soDien -50)*1.5f;
            //}
            //Console.WriteLine("Số điện tiêu dùng là: {0} và cươc phí là: {1}", soDien, tongTien);

            //C2
            //int soDien = 12;
            //float tongTien =30;
            //if (soDien <= 50 && soDien > 30)
            //{
            //    tongTien += (soDien - 30) * 1.2f;
            //}
            //else
            //{
            //    tongTien += (50 - 30) * 1.2f + (soDien - 50) * 1.5f;
            //}
            //Console.WriteLine("Số điện tiêu dùng là: {0} và cươc phí là: {1}", soDien, tongTien);

            //C3
            int soDien = 31;
            float tongTien = 30;
            // số điện trên 30 số
            soDien = soDien - 30;
            
            // từ 30 đến 50 số điện
            if (soDien > 0 && soDien<20)
            {
                tongTien += soDien * 1.2f;
            }
            // quá 50 số điện
            else
            {
                 tongTien += 20 * 1.2f;
                //tính số điện trên 50 số
                soDien -= 20;
                tongTien += soDien * 1.5f;
            }

            Console.WriteLine("Số điện tiêu dùng là: {0} và cươc phí là: {1}", soDien+50, tongTien);

        }
    }
}
