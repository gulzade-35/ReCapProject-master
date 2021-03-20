using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        
        public static string CarListed = "Arabalar Listelendi";
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string CarAddedError = "Araba Eklenemedi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarUpdatedError = "Araba Güncellemedi";
        public static string CarDeleted = "Araba Silindi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandNameInvalid = "Marka İsmi Geçersiz";
        public static string BrandAddedError = "Marka ismi en az 2 karakterden olmalı";
        public static string BrandUpdated = "Marka İsmi Güncellendi";
        public static string BrandUpdatedError = "Marka ismi en az 2 karakter olmalı";
        public static string BrandDeleted = "Marka İsmi Silindi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralama İşlemi Gerçekleşti";
        public static string RentalAddedError = "Kiralama İşlemi Gerçekleşemedi";
        public static string RentalDeleted = "Kiralama işlemi İptal Edildi";
        public static string RentalUpdated = "Kiralama İşlemi Güncellendi";
        public static string RentalUpdatedError = "Kiralama İşlemi Güncellenemedi";
        public static string RentalReturned = "Aracınız Teslim Edildi";
        public static string MaintenanceTime = "Sistem Bakımda";

        public static string CarImageCountError = " Bir araba için maksimum 5 resim yüklenebilir.";
        public static string CarImagesAdded = "Araba fotoğrafı eklendi";
        public static string CarImagesListed = "Araba fotoğrafları listelendi";
        public static string CarImagesUpdated = "Araba fotoğrafları güncellendi";
        public static string CarImageDeleted = "Araba fotoğrafı silindi";
        public static string CarImagesNotFound = "Araba resmi sistemde bulunmamaktadır";

        public static string AddedCarImage = "Araba için yüklenilen resim başarıyla eklendi.";
        public static string DeletedCarImage = "Arabanın resmi başarıyla silindi.";
        public static string UpdatedCarImage = "Araba için yüklenilen resim başarıyla güncellendi.";
        public static string FailedCarImageAdd = "Bir araba 5'den fazla resme sahip olamaz.";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
    }
}
