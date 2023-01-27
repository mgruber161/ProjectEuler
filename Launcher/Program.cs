Console.WriteLine("Which project would you like to run? ");

const string objectToInstantiate = "Launcher.001, Launcher";

var objectType = Type.GetType(objectToInstantiate);

var instantiatedObject = Activator.CreateInstance(objectType);

instantiatedObject.Main();
