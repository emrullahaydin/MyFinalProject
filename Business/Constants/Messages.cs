using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductDeleted = "Ürün silindi";
        public static string MainternanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bu Kategoriye en fazla 10 ürün eklenebilir.";
        public static string ProductNameAlreadyExist = "Bu İsimde ürün sistmde bulunmaktadır. Eklenemez.";
        public static string CategoryLimitExeded = "Categori limti doldu.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string PasswordError="Parola Hatalı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string UserRegistered = "Kullanıcı Kayıt Edildi";
    }
}
