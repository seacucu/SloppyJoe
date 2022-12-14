using System;

namespace SloppyJoe
{
    internal class MenuItem
    {
        // Field
        // 蛋白質
        public string[] Proteins =
            { "燒肉", "臘腸", "燻雞", "火腿", "燻肉", "豆腐" };

        // 配料
        public string[] Condiments =
            { "酸黃瓜", "番茄", "蜂蜜芥末", "起司", "泡菜", "塔塔" };

        // 麵包
        public string[] Bread =
            { "小麥麵包", "黑麥麵包", "白麵包", "燕麥麵包", "麵包捲" };

        // 描述
        public string Desc = string.Empty;

        // 價格
        public string Price = string.Empty;

        // Instantiation
        public static Random rand = new Random();

        // Method
        public void Generate()
        {
            // 三種成分各隨機取出一項並生成描述
            string rdProtein = Proteins[rand.Next(Proteins.Length)];
            string rdCondiments = Condiments[rand.Next(Condiments.Length)];
            string rdBread = Bread[rand.Next(Bread.Length)];
            Desc = $"{rdCondiments}{rdProtein}{rdBread}";

            // 生成價格
            int totalprice = rand.Next(100,200);
            Price = $"NT${totalprice}";
        }
    }
}