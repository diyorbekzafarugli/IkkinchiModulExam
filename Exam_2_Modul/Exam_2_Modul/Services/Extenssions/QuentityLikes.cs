using Exam_2_Modul.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2_Modul.Services.Extenssions;

public static class QuentityLikes
{
    static int QuentityLikesMusics(this List<MusicDto> dtos)
    {
        var summLikes = 0;
        foreach (var music in dtos)
        {
            summLikes += music.QuentityLikes;
        }

        return summLikes;
    }
}
