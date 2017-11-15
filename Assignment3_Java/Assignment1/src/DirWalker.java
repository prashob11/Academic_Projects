import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.apache.commons.csv.CSVPrinter;
import org.apache.commons.csv.CSVRecord;
import org.apache.commons.csv.CSVFormat;

public class DirWalker {
	final static String header[] = {"First Name","Last Name","Street Number","Street","City","Province","Postal Code","Country","Phone Number","email Address"};
	static List<CSVRecord> dirData = new ArrayList<CSVRecord>();
	static CSVPrinter csvFilePrinter;
	static int validCount;
	static int skippedCount;
	
    public void walk( String path ) {

        File root = new File( path );
        File[] list = root.listFiles(); 
        
	try {			
        
		if (list == null) return;

        for ( File f : list ) {
            if ( f.isDirectory() ) {
                walk( f.getAbsolutePath() );
                //Print all records before reading files from other directory and clear dirData list
                	csvFilePrinter.printRecords(dirData);
                	dirData.clear();
            }
            else {
                //Append all records for files in same directory to dirData
                dirData.addAll(SimpleCsvParser.mainparser(f.getAbsolutePath()));
            }
            
        }

	} catch (IOException e) {
			SimpleLogging.logger.info(e.toString());
		}

    }

    
    public static void main(String[] args) throws IOException {
    	new File("Output").mkdir();
    	String outputFile="./Output/Output.csv";
    	
    	SimpleLogging.mainlogger(null);
    	FileWriter fileWriter = new FileWriter(outputFile);
    	DirWalker fw = new DirWalker();
    	csvFilePrinter = new CSVPrinter(fileWriter,CSVFormat.EXCEL.withHeader(header));
    	
    	//Start execution timer
    	System.out.println("Execution Started!!");
    	final long startTime = System.currentTimeMillis();
    	fw.walk("Sample Data" );
        //Stop execution timer
    	final long endTime = System.currentTimeMillis();//Stop execution timer
        csvFilePrinter.close();
        
        // Log the Total Valid records, Skipped records and Execution time
        SimpleLogging.logger.info("Total Valid Records: " + validCount);
        SimpleLogging.logger.info("Total Skipped Records: " + skippedCount);
        SimpleLogging.logger.info("Total execution time: " + (endTime - startTime) + " ms");
        
        System.out.println("Execution Complete!!\nPlease Check Output Folder for CSV and Log file!");
        System.out.println("Total Valid Records: " + validCount);
        System.out.println("Total Skipped Records: " + skippedCount);
        System.out.println("Total execution time: " + (endTime - startTime) + " ms");
        
    }

}