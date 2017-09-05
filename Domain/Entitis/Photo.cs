using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitis
{
    public class Photo
    {
        int IdPhoto { get; set; }
        int IdAlbum { get; set; }
        string NamePhoto { get; set; }
        string DescriptionPhoto { get; set; }
        int LikeCount { get; set; }
        int IdUser { get; set; }
        string HashTag { get; set; }
        string PathToPhoto { get; set; }
    }
}
