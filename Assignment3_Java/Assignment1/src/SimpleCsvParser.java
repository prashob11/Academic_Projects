import java.io.FileReader;
import java.io.IOException;
import java.io.Reader;
import java.util.ArrayList;
import java.util.List;

import org.apache.commons.csv.CSVFormat;
import org.apache.commons.csv.CSVRecord;

public class SimpleCsvParser {
	
	public static List<CSVRecord> mainparser(String path) {
		Reader in;
		List<CSVRecord> fileData = new ArrayList<CSVRecord>();
		
		try {
			in = new FileReader(path);
			Iterable<CSVRecord> records = CSVFormat.EXCEL.parse(in);
			int row = 1;
			for (CSVRecord record : records) {
				
				if(row!=1){
					boolean validRecord=true;
					for(int i=0 ; i<record.size();i++) {
						if (record.get(i).isEmpty()) {
							SimpleLogging.logger.info(path+" Row:"+row+" Column:"+ DirWalker.header[i]);
			    		validRecord=false;
						}
					}
			    
		    	if (validRecord) {
			    fileData.add(record);
			    DirWalker.validCount++;
		    	}
		    	else {
		    		DirWalker.skippedCount++;
		    	}
		    	
				}
				row++;
			}
		} catch ( IOException e) {
			SimpleLogging.logger.info(e.toString());
		}
		
		return fileData;		
	}

}
