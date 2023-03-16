using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_CustomerSystem.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名必填")]
        public string Name { get; set; }
        [DisplayName("電話")]
        [Required(ErrorMessage = "姓名電話")]
        public string Phone { get; set; }
        [DisplayName("信箱")]
        [Required(ErrorMessage = "信箱必填")]
        [EmailAddress(ErrorMessage = "信箱格式錯誤")]
        public string Email { get; set; }
        [DisplayName("地址")]
        [Required(ErrorMessage = "地址必填")]
        public string Address { get; set; }
    }
}
