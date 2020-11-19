using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GridFilter
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();
             public ObservableCollection<Item> Items{ get => _items; set { Set(() => Items, ref _items, value); }}

        public MainWindowViewModel()
        {
            Items.Add(new Item(1, "aaaa"));
            Items.Add(new Item(2, "aabb"));
            Items.Add(new Item(3, "bbbb"));
        }
    }
}
