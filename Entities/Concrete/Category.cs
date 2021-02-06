using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak class kalmasın standardı... Diyelim
    //bu sebeple gruplamamız gerekiyor. Bir yere 
    //bağlanmadan olmaz :)
  public  class Category:IEntity

    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
