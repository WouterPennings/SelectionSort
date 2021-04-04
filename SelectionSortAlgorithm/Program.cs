using System;
using System.Collections.Generic;

namespace SelectionSortAlgorithm {
	class Program {
		static void Main() {
			Console.WriteLine("Bonjour!\n");
			List<int> numberList = new List<int>() { 18, 21, 14, 7, 8, 5, 17, 3, 6, 22 };

			numberList = SelectionSort(numberList);

			Console.Write("Your list is sorted: ");
			ShowList(numberList);
		}

		static private List<int> SelectionSort(List<int>listInput) {
			List<int> numberListInput = listInput;
			for(int i = 0; i < numberListInput.Count - 1; i++) {
				int minIndex = i;
				for(int j = i + 1; j < numberListInput.Count; j++) {
					if(numberListInput[j] < numberListInput[minIndex]) {
						minIndex = j;
					}
				}
				Console.WriteLine("\n=======================================================================\n");
				ShowList(numberListInput);
				numberListInput = SwitchIndexes(numberListInput, minIndex, i);
			}
			return numberListInput;
		} 

		static private List<int> SwitchIndexes(List<int> listInput, int minIndex, int currentIndex) {
			int x = listInput[minIndex];
			listInput[minIndex] = listInput[currentIndex];
			listInput[currentIndex] = x;
			return listInput;
		}

		static private void ShowList(List<int> listInput) {
			foreach(int number in listInput) {
				Console.Write(number + " " );
			}
			Console.WriteLine("");			
		}
	}
}
