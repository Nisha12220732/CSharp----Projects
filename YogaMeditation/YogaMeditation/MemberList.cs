using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace YogaMeditation
{
    public  class MemberList
    {
        public static ArrayList members = null;
        public MemberList() { 
            if(members == null) 
              members = new ArrayList();
        }

        public void AddYogaMember(MeditationCenter newmenber)
        {
            members.Add(newmenber);
        }

        public void displayMembers()
        {
            foreach(MeditationCenter m in members)
            {
                Console.WriteLine($"Member Id: {m.MemberId}, Age: {m.Age},Height: {m.Height},Weight: {m.Weight} ,Goal: {m.Goal} ,BMI: {m.BMI}");
            }
        }
        public double CalculateBMI(int memberId)
        {
            foreach (object obj in members)
            {
                MeditationCenter m = (MeditationCenter)obj;

                if (m.MemberId == memberId)
                {
                    m.BMI = (m.Weight *100 * 100) / (m.Height * m.Height);
                    return m.BMI;
                }
            }
            return 0.00;
        }

        public int CalculateYogaFee(int memberId)
        {
            foreach (object obj in members)
            {
                MeditationCenter m = (MeditationCenter)obj;

                if (m.MemberId == memberId)
                {
                    if (m.BMI >= 25 && m.BMI < 30)
                        return 2000;
                    else if (m.BMI >= 30 && m.BMI < 35)
                        return 2500;
                    else
                        return 3000;
                }
            }
            return -1;
        }

    }

}
