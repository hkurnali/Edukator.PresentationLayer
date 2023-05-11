using Microsoft.AspNetCore.Identity;

namespace Edukator.PresentationLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Parola çok kısa en az 6 karakter olmalı"
            };
        }
        public override IdentityError PasswordRequiresLower()

        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola 1  en az  küçük harf içermeli"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola  en az 1 büyük Harf içermeli"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
           

            return new IdentityError
            {

                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola  en az 1 sembol içermeli"
            };
             
    }
    }
}
