﻿using System;
namespace StyleCop
{
    internal class Starter
    {
        public void Run()
        {
            var action = new Actions();
            var rnd = new Random();
            var result = new Result(false);
            for (var i = 0; i < 100; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0:
                        result = action.Method_1();
                        break;
                    case 1:
                        result = action.Method_2();
                        break;
                    case 2:
                        result = action.Method_3();
                        break;
                }

                if (result.Status == false)
                {
                    Logger.Instance.Write(LogType.Error, $"Action failled by a reason: {result.ErrorMessage}");
                }
            }
        }
    }
}
