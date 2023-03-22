using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6.Exercise15
{
    class Event_Exercise15
    {
        private void OnChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // Add Event
            if (e.Action == NotifyCollectionChangedAction.Add)
                if(e.NewItems?[0] is int newnumber)
                    Console.WriteLine($"Element {newnumber} is added in collection");

            // Remove Event
            if (e.Action == NotifyCollectionChangedAction.Remove)
                if (e.OldItems?[0] is int oldnumber)
                    Console.WriteLine($"Element {oldnumber} is removed from collection");
        }

        public Event_Exercise15()
        {
            ObservableCollection<int> numbers = new ObservableCollection<int>();

            numbers.CollectionChanged += OnChanged;
            numbers.Add(1);
            numbers.Add(23);
            numbers.Add(113);
            numbers.RemoveAt(1);
        }
    }
}
