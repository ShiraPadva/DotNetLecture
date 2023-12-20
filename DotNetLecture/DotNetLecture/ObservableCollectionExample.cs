using System.Collections.ObjectModel;

namespace DotNetLecture
{
    internal class ObservableCollectionExample
    {
        public static void demo()
        {
            // Create an ObservableCollection of strings
            ObservableCollection<string> observableCollection = new ObservableCollection<string>();

            // Subscribe to the CollectionChanged event
            observableCollection.CollectionChanged += OnCollectionChanged;

            // Add, remove, or modify items in the collection
            observableCollection.Add("Item1");
            observableCollection.Add("Item2");
            observableCollection.Remove("Item1");
            observableCollection[0] = "ModifiedItem";

            // Output:
            // Collection changed: New item added - Item1
            // Collection changed: New item added - Item2
            // Collection changed: Item removed - Item1
            // Collection changed: Item replaced - ModifiedItem
        }

        private static void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine($"Collection changed: New item added - {newItem}");
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine($"Collection changed: Item removed - {oldItem}");
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                foreach (var newItem in e.NewItems)
                {
                    Console.WriteLine($"Collection changed: Item replaced - {newItem}");
                }
            }
        }
    }
}
