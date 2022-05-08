using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime="Araba bakımda";
        public static string CarsListed="Arabalar listelendi";
        public static string CarDeleted="Araç silindi";
        public static string CarUpdate="Araç güncellendi";
        public static string BrandAdded="Marka eklendi";
        public static string BrandDeleted="Marka silindi";
        public static string BrandListed="Markalar listelendi";
        public static string BrandUpdated="Marka güncellendi";
        public static string ColorAdded="Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorListed="Renkler listelendi";
        public static string ColorUpdated="Renk güncellendi";
        public static string UserAdded="Kullanıcı eklendi";
        public static string UserDeleted="Kullanıcı silindi";
        public static string UsersListed="Kullanıcılar listelendi";
        public static string UserUpdated="Kullanıcı güncellendi";
        public static string CarOccupied="Araç meşgül";
        public static string RentalAdded="Kiralama eklendi";
        public static string CarImagesLimit="Araç resimleri 5'den fazla olamaz";
        public static string CarImageAdded="Araç resmi eklendi";
        public static string AccessTokenCreated="Erişim token'ı oluşturuldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Başarıyla giriş yapıldı" ;
        public static string UserRegistered="Kullanıcı başarıyla Kayıt edildi";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
    }
}
