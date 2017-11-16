import java.io.IOException;
import java.util.logging.FileHandler;
import java.util.logging.LogManager;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class SimpleLogging {

	static Logger logger = Logger.getLogger("MyLog");

	public static void mainlogger(String[] args) {
		try {
			LogManager.getLogManager().reset();
			// This block configure the logger with handler and formatter
			FileHandler fh = new FileHandler("../Output/MyLogFile.log");
			logger.addHandler(fh);
			SimpleFormatter formatter = new SimpleFormatter();
			fh.setFormatter(formatter);
		} catch (SecurityException e) {
			e.printStackTrace();
			// can't use logger here
		} catch (IOException e) {
			// can't use logger here
			e.printStackTrace();
		}

	}

}
