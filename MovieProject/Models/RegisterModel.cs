﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieProject.Models
{
    public class RegisterModel
    {
        [Key]
        public int ID { set; get; }
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]

        public string Name { set; get; }
        [Display(Name = "Tên tài khoản")]
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        public string UserName { set; get; }
        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Mật khẩu có ít nhất 6 ký tự")]
        public string Password { set; get; }
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Mật khẩu xác nhận không khớp")]
        public string ConfirmPassword { set; get; }
        
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Yêu cầu nhập Số điện thoại")]
        public string Phone { set; get; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string Email { set; get; }
    }
}