[Custom]
struct Duration {
	int Milliseconds;

	// Return value in the format XhXmXs
	public override string ToString()
		=> $"{Milliseconds / 3600000:d2}:{(Milliseconds / 60000) % 60:d2}:{(Milliseconds / 1000) % 60:d2}";
}

class Message {
	Duration RemainingTime;
	Duration StartTime;
}