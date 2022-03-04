using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).Empty().WithMessage("Mail Adresini boş Geçemezsiniz");
            RuleFor(x => x.Subject).Empty().WithMessage("Konu Adını boş Geçemezsiniz");
            RuleFor(x => x.UserName).Empty().WithMessage("Kullanıcı Adını boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az üç karakter girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(30).WithMessage("Lütfen en az üç karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 den fazla karakter girmeyiniz");

        }
    }
}
