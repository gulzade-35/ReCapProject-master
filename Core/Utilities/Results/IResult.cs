using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //İşlem sonucu ve
    //Mesaj vermek istiyoruz.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
