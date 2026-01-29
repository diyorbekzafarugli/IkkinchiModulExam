using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_2_Modul.Dtos;

public class CreateMusicDto
{
    public string Name { get; set; }
    public double MB { get; set; }
    public string AuthorName { get; set; }
    public string Discription { get; set; }
    public int QuentityLikes { get; set; }
}
