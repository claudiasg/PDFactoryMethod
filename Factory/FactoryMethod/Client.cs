static void Main()
        {
            AbstractFactory factory = new ConcretFactory();
            IArchivo audio = factory.crear(ConcretFactory.audio);
            audio.Reproducir();

	    IArchivo video = factory.crear(ConcretFactory.video);
            video.Reproducir();
        }

