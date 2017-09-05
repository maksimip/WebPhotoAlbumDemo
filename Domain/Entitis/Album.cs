using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitis
{
    public class Album
    {
        int IdAlbum { get; set; }
        string NameAlbum { get; set; }
        string DescriptionAlbum { get; set; }
        int IdUser { get; set; }
    }
}
