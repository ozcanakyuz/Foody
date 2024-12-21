using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DtoLayer.Dtos.About_Dtos
{
    public class GetByIdAboutDto
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
