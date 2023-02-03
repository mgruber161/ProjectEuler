var lexi = EulerLib.EulerHelper.GetPermutations(new int[] {0,1,2,3,4,5,6,7,8,9}, 10).ToList();
lexi[999_999].ToList().ForEach(x => Console.Write(x));