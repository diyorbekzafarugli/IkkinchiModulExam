using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2_Modul.Services.Extenssions;

public static class GetMusic
{
    static long GetMusicKB(this int mb)
    {
        return mb * 1024;
    }
}
