using Exam_2_Modul.Dtos;
using Exam_2_Modul.Entities;
using Exam_2_Modul.Services.Extenssions;

namespace Exam_2_Modul.Services;

public class MusicServices : IMusicServices
{
    List<Music> Musics;
    public MusicServices()
    {
        Musics = new List<Music>();
    }

    public Guid AddMusic(CreateMusicDto createMusicDto)
    {
        var music = new Music();
        music.Id = Guid.NewGuid();
        music.Name = createMusicDto.Name;
        music.AuthorName = createMusicDto.AuthorName;
        music.Discription = createMusicDto.Discription;
        music.QuentityLikes = createMusicDto.QuentityLikes;
        music.MB = createMusicDto.MB;

        Musics.Add(music);
        return music.Id;
    }


    public bool DeleteMusic(Guid id)
    {
        for (int i = 0; i < Musics.Count; i++)
        {
            if (Musics[i].Id == id)
            {
                Musics.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public bool UpdateMusic(UpdateMusicDto updateMusicDto)
    {
        foreach (var music in Musics)
        {
            if (music.Id == updateMusicDto.Id)
            {
                music.Name = updateMusicDto.Name;
                music.AuthorName = updateMusicDto.AuthorName;
                music.Discription = updateMusicDto.Discription;
                music.QuentityLikes = updateMusicDto.QuentityLikes;
                music.MB = updateMusicDto.MB;
                return true;
            }
        }
        return false;
    }

    public List<MusicDto> GetAllMusicAboveMinSize(double minSize)
    {
        var musics = new List<MusicDto>();

        foreach (var music in Musics)
        {
            var musicDto = new MusicDto();
            if (music.MB > minSize)
            {
                musicDto.Name = music.Name;
                musicDto.AuthorName = music.AuthorName;
                musicDto.MB = music.MB;
                musicDto.QuentityLikes = music.QuentityLikes;
                musicDto.Discription = music.Discription;
                musics.Add(musicDto);
            }
        }

        return musics;
    }

    public List<MusicDto> GetAllMusicAboveSize(double minSize)
    {
        var musics = new List<MusicDto>();
        foreach (var music in Musics)
        {
            var musicDto = new MusicDto();
            if (music.MB > minSize)
            {
                musicDto.Name = music.Name;
                musicDto.AuthorName = music.AuthorName;
                musicDto.MB = music.MB;
                musicDto.QuentityLikes = music.QuentityLikes;
                musicDto.Discription = music.Discription;
                musics.Add(musicDto);
            }
        }

        return musics;
    }

    public List<MusicDto> GetAllMusicByAuthorName(string name)
    {
        var musics = new List<MusicDto>();

        foreach (var music in Musics)
        {
            var musicDto = new MusicDto();

            if (music.AuthorName == name)
            {
                musicDto.Name = music.Name;
                musicDto.AuthorName = music.AuthorName;
                musicDto.MB = music.MB;
                musicDto.QuentityLikes = music.QuentityLikes;
                musicDto.Discription = music.Discription;
                musics.Add(musicDto);
            }
        }

        return musics;
    }

    public MusicDto GetMostLikedMusic()
    {
        var music = new MusicDto();
        music.QuentityLikes = Musics[0].QuentityLikes;

        for (int i = 0; i < Musics.Count; i++)
        {
            if (Musics[i].QuentityLikes > music.QuentityLikes)
            {
                music.QuentityLikes = Musics[i].QuentityLikes;
            }
        }
        return music;
    }

    public MusicDto? GetMusicByName(string name)
    {
        var musicDto = new MusicDto();

        foreach (var music in Musics)
        {
            if (music.Name == name)
            {
                musicDto.Name = music.Name;
                musicDto.AuthorName = music.AuthorName;
                musicDto.Discription = music.Discription;
                musicDto.QuentityLikes = music.QuentityLikes;
                musicDto.MB = music.MB;
                return musicDto;

            }
        }

        return null;
    }

    public List<MusicDto> GetMusicWithLikesInRange(int minlikes, int maxlikes)
    {
        var musics = new List<MusicDto>();

        for (int i = 0; i < Musics.Count; i++)
        {
            var music = new MusicDto();

            if (Musics[i].QuentityLikes > minlikes && Musics[i].QuentityLikes < maxlikes)
            {
                music.AuthorName = Musics[i].AuthorName;
                music.Name = Musics[i].Name;
                music.Discription = Musics[i].Discription;
                music.QuentityLikes = Musics[i].QuentityLikes;
                music.MB = Musics[i].MB;
                musics.Add(music);
            }

        }
        return musics;
    }

    public List<MusicDto> GetTopMostLikedMusic(int count)
    {
        var musics = new List<MusicDto>();
        var music = Musics[0].QuentityLikes;

        for (int i = 0; i < Musics.Count; i++)
        {
            var musicDto = new MusicDto();

            if (Musics[i].QuentityLikes >= count)
            {
                musicDto.AuthorName = Musics[i].AuthorName;
                musicDto.Name = Musics[i].Name;
                musicDto.QuentityLikes = Musics[i].QuentityLikes;
                musicDto.MB = Musics[i].MB;
                musicDto.Discription = Musics[i].Discription;
                musics.Add(musicDto);

            }
        }

        return musics;
    }

    public double GetTotalMusicSizeByAuthor(string authorName)
    {
        var totalMB = 0;

        foreach (var music in Musics)
        {
            if (music.AuthorName == authorName)
            {
                totalMB += (int)music.MB;
            }
        }
        return totalMB;
    }

}
