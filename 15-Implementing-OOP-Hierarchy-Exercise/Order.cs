
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
    public class Order
    {        
        private List<MenuItem> _items = new(); //по-краткият вариант на изписване на долното. Когато е написано така, компилатора автоматично създава празен конструктор, който ако има някъде в кода инстанциране на нови елементи, ги прави. Затова не е необходимо да се пише конструктора, защото той автоматично се случва.  

        //private List<MenuItem> _items;

        //public Order(string item) 
        //{
        //    this._items = new List<MenuItem>();
        //}

        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

        public void AddItem(MenuItem item)
        {
            this._items.Add(item);
        }

        public decimal GetTotal()
        {
            return this._items.Select(i => i.Price).Sum();
        }
    }
}
