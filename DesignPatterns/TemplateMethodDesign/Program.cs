using System;

namespace TemplateMethodDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm scoringAlgorithm;
            
            Console.WriteLine("Mans");
            scoringAlgorithm=new MansScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10,new TimeSpan(0,2,34)));

            Console.WriteLine("womens");
            scoringAlgorithm=new WomensScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10,new TimeSpan(0,2,34)));

            Console.WriteLine("Child");
            scoringAlgorithm=new MansScoringAlgorithm();
            Console.WriteLine(scoringAlgorithm.GenerateScore(10,new TimeSpan(0,2,34)));
        }
    }
    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits,TimeSpan time )
        {
            int score=CalculateBaseScore(hits);
            int redaction= CalculateReducation(time);
            return CalculateOverallScore(score,redaction);
        }

          public abstract int CalculateOverallScore(int score, int redaction);
          public abstract int CalculateBaseScore(int hits);
          public abstract int CalculateReducation(TimeSpan time);
         
     }
     class MansScoringAlgorithm : ScoringAlgorithm
     {
          public override int CalculateBaseScore(int hits)
          {
               return hits*100;
          }

          public override int CalculateOverallScore(int score, int redaction)
          {
              return score-redaction;
          }

          public override int CalculateReducation(TimeSpan time)
          {
               return (int)time.TotalSeconds/5;
          }
     }
     class WomensScoringAlgorithm : ScoringAlgorithm
     {
          public override int CalculateBaseScore(int hits)
          {
                return hits*100;
          }

          public override int CalculateOverallScore(int score, int redaction)
          {
                return score-redaction;
          }

          public override int CalculateReducation(TimeSpan time)
          {
              return (int)time.TotalSeconds/3;
          }
     }
     class ChildScoringAlgorithm : ScoringAlgorithm
     {
          public override int CalculateBaseScore(int hits)
          {
                return hits*100;
          }

          public override int CalculateOverallScore(int score, int redaction)
          {
               return score*80;
          }

          public override int CalculateReducation(TimeSpan time)
          {
               return (int)time.TotalSeconds/2;
          }

          
     }

}
