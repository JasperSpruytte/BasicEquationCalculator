using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BasicEquationCalculator
{
    public class EquationCalculator
    {
        public Point CalculateIntersection(string equation1, string equation2)
        {
            float[] constantsEquation1 = GetConstantsFromEquation(equation1);
            float[] constantsEquation2 = GetConstantsFromEquation(equation2);

            float x = (constantsEquation2[1] - constantsEquation1[1]) / (constantsEquation1[0] - constantsEquation2[0]);
            float y = constantsEquation1[0] * x + constantsEquation1[1];
            
            return new Point(x, y);
        }

        private float[] GetConstantsFromEquation(string equation)
        {
            float[] constants = new float[2];
            string expression = @"y=([-]?\d+\.?\d*)x([\+-]\d+\.?\d*)?";
            Regex regex = new Regex(expression, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(equation) || !regex.IsMatch(equation))
            {
                throw new ArgumentException("The equations have to be in the form y=ax+b.");
            }

            Match matchEquation = regex.Match(equation);
            constants[0] = GetConstantFromRegexGroup(matchEquation.Groups[1].Value);
            constants[1] = GetConstantFromRegexGroup(matchEquation.Groups[2].Value);

            return constants;
        }

        private float GetConstantFromRegexGroup(string value)
        {
            float valueFloat;

            if (value == "")
                valueFloat = 0;
            else
                valueFloat = float.Parse(value);

            return valueFloat;
        }
    }
}
