namespace HW3Project.Models
{
    public static class Repository
    {
        public static List<Item> Items { get; set; } = new List<Item>();

        // Adds a new item to the collection and assign unique Id
        public static void AddItem(Item item)
        {
            // Check if the Items collection already contain any items.
            if (Items.Any())
            {
                // If there are existing items, set the new item's ID to one more than the highest current ID.
                item.Id = Items.Max(i => i.Id) + 1;
            }
            else
            {
                // If the collection is empty, initialize the first item with an ID of 1.
                item.Id = 1;
            }

            // Adds the new item to the Items collection.
            Items.Add(item);
        }

        // Removes an item from the collection based on its ID.
        public static void DeleteItem(int id)
        {
            // Finds the first item in the collection with the matching ID.
            var item = Items.FirstOrDefault(i => i.Id == id);

            // If an item with the specified ID exists, it is removed from the collection.
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        // Updates the quantity of an existing item identified by itemId.
        public static void UpdateItemQuantity(int itemId, int newQuantity)
        {
            // Finds the item in the collection with the specified ID.
            var item = Items.FirstOrDefault(i => i.Id == itemId);

            // If the item exists, its quantity is updated to the new value.
            if (item != null)
            {
                item.Quantity = newQuantity;
            }
        }

        // Calculate and return the total quantity of all items in the collection.
        public static int? GetTotalItemCount() => Items.Sum(item => item.Quantity);
    }
}
