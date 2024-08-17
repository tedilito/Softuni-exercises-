namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                    break;

                string[] data = input.Split();
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item item = new Item { Name = itemName, Price = itemPrice };
                Box box = new Box { SerialNumber = serialNumber, Item = item, ItemQuantity = itemQuantity };
                boxes.Add(box);
            }

            var sortedBoxes = boxes.OrderByDescending(b => b.BoxPrice);


            foreach (var box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice => Item.Price * ItemQuantity;
    }
}
