using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    [DataServiceKey("UserID")]
    public class Me
    {
        public int CurrentDivision { get; set; }
        public string FullName { get; set; }
        public string PictureUrl { get; set; }
        public byte[] ThumbnailPicture { get; set; }
        public string ThumbnailPictureFormat { get; set; }
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string LanguageCode { get; set; }
        public long Legislation { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Language { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string Mobile { get; set; }
        public string ServerTime { get; set; }
        public double ServerUtcOffset { get; set; }
    }
}
