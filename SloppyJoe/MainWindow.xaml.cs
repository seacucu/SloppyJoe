using System.Windows;

namespace SloppyJoe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            // 處理菜單項目 #1-5
            MenuItem[] menuItems = new MenuItem[5];
            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Bread = new string[] 
                    { "奶油貝果", "洋蔥貝果", "黑麥貝果", "鮮奶貝果" };
                }
                menuItems[i].Generate();
            }
            // 將文字加入 Textblock #1-5
            item1.Text = menuItems[0].Desc; price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Desc; price2.Text = menuItems[0].Price;
            item3.Text = menuItems[2].Desc; price3.Text = menuItems[0].Price;
            item4.Text = menuItems[3].Desc; price4.Text = menuItems[0].Price;
            item5.Text = menuItems[4].Desc; price5.Text = menuItems[0].Price;

            // 處理菜單項目 #6
            MenuItem itemSpecial = new MenuItem()
            {
                Proteins = new string[] { "澳洲火腿", "蘑菇肉排", "義式肉腸" },
                Bread = new string[] { "鮮奶麵包捲", "玉米餅", "皮塔餅" },
                Condiments = new string[] { "第戎芥末", "新鮮山葵", "大骨原汁" }
            };
            itemSpecial.Generate();
            // 將文字加入Textblock #6
            item6.Text = itemSpecial.Desc;
            price6.Text = itemSpecial.Price;

            // 處理加蛋項目 #6
            MenuItem itemAddEgg = new MenuItem();
            itemAddEgg.Generate();
            addEgg.Text = $"加蛋加 {itemAddEgg.Price} 元";
        }
    }
}