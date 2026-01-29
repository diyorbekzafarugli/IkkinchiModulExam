using Exam_2_Modul.Dtos;

namespace Exam_2_Modul.Services
{
    public interface IMusicServices
    {
        public Guid AddMusic(CreateMusicDto createMusicDto);
        public bool DeleteMusic(Guid id);
        public bool UpdateMusic(UpdateMusicDto updateMusicDto);
        public List<MusicDto> GetAllMusicByAuthorName(string name);
        public MusicDto GetMostLikedMusic();
        public MusicDto? GetMusicByName(string name);
        public List<MusicDto> GetAllMusicAboveMinSize(double minSize);
        public List<MusicDto> GetAllMusicAboveSize(double minSize);
        public List<MusicDto> GetTopMostLikedMusic(int count);
        public List<MusicDto> GetMusicWithLikesInRange(int minlikes, int maxlikes);
        public double GetTotalMusicSizeByAuthor(string authorName);

    }
}