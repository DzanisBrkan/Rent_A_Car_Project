using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_A_Car.Model
{
    public class RecommenderModel
    {
        public List<Model.Vozilo> listToRecommend { get; set; }
        public List<Model.Vozilo> others { get; set; }
    }
}
