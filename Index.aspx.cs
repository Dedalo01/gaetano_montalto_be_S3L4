using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace eserS3L4
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Automobile> listaAutomobili = new List<Automobile>();

            // Popolo lista Automobili
            listaAutomobili.Add(new Automobile("Toyota Corolla", 20000, "https://immagini.alvolante.it/sites/default/files/styles/image_gallery_big/public/serie_auto_galleria/2022/09/toyota_corolla_ant_0.png"));
            listaAutomobili.Add(new Automobile("Yaris Hybrid", 34500.14, "https://cdn.drivek.com/configurator-imgs/cars/it/$original$/TOYOTA/YARIS-HYBRID/43155_HATCHBACK-5-DOORS/toyota-yaris-front-view.jpg"));
            listaAutomobili.Add(new Automobile("Suzuki S-cross Hybrid", 35000.99, "https://i.ytimg.com/vi/4vch3npo8U8/maxresdefault.jpg"));

            foreach (Automobile automobile in listaAutomobili)
            {
                ListItem listItem = new ListItem(automobile.Nome, automobile.ImageUrl);
                CarsDropDown.Items.Add(listItem);
            }


        }


    }
}