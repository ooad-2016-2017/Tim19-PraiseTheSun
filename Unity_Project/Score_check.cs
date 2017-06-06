using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace scoreccc { 
    public class Score_check
{
    static int score = 0;
    public String increase()
    {
        score++;
        return "Score: " + score.ToString();
    }
    public String decrease()
    {
        score--;
        return "Score: " + score.ToString();
    }
    public String dajText()
    {
        return "Score: " + score.ToString();
    }

}
}

