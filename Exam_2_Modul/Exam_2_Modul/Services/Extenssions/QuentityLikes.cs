using Exam_2_Modul.Dtos;

namespace Exam_2_Modul.Services.Extenssions;

public static class QuentityLikes
{
    public static int QuentityLikesMusics(this List<MusicDto> dtos)
    {
        var summLikes = 0;
        foreach (var music in dtos)
        {
            summLikes += music.QuentityLikes;
        }

        return summLikes;
    }
}
