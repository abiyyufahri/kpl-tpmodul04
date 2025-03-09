using tpmodul4_103022300121;


int val = KodePos.GetKodePos(KodePos.Kelurahan.Batununggal);
Console.WriteLine(val);
val = KodePos.GetKodePos(KodePos.Kelurahan.Kujangsari);
Console.WriteLine(val);
val = KodePos.GetKodePos(KodePos.Kelurahan.Mengger);
Console.WriteLine(val);

Console.WriteLine("===================================================");

DoorMachine door = new DoorMachine();
Console.WriteLine($"Status awal: {door.GetCurrentState()}");

door.ActivateTrigger(DoorMachine.Trigger.BUKA_PINTU);
door.ActivateTrigger(DoorMachine.Trigger.BUKA_PINTU); 
door.ActivateTrigger(DoorMachine.Trigger.KUNCI_PINTU);
door.ActivateTrigger(DoorMachine.Trigger.KUNCI_PINTU); 
