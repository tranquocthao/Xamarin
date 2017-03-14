using List.Core.Services;
using List.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        #region MainViewModel

        #region Item

        private string mItem;

        public string Item
        {
            get
            {
                return mItem;
            }
            set
            {
                mItem = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region init
        public MainViewModel(IKittenService service)
        {
            Item = "List Number";
            var list = new List<Kitten>();
            for(var i = 0; i < 10; i++)
            {
                var newKitten = service.CreateKitten(i.ToString());

                list.Add(newKitten);
            }

            Kittens = list;
        }

        #endregion

        #region Kittens
        private List<Kitten> _kittens;
        public List<Kitten> Kittens
        {
            get
            {
                return _kittens;
            }

            set
            {
                _kittens = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region ClickItem

        private MvxCommand<Kitten> _clickItem;
        public MvxCommand<Kitten> ClickItem
        {
            get
            {
                return (_clickItem ?? (_clickItem = new MvxCommand<Kitten>(btnClick)));
            }
        }

        public void btnClick(Kitten kitten)
        {
            Item = kitten.Number;
        }

        #endregion

        #endregion
    }
}
