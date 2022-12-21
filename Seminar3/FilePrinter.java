package Seminar3;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.List;

public class FilePrinter implements Printable {

    private String sentPath = "Seminar3/res/"; // путь на директорию данных
    private String fileName = "info"; // имя файла

    @Override
    public void Print(List<Shape> shapes) throws GraphicException {
        
        File file = new File(sentPath + fileName).getAbsoluteFile();

        try(FileWriter writer = new FileWriter(file, StandardCharsets.UTF_8, false)) {
            for (Shape shape : shapes) { 
                writer.append(shape.toString());     
                writer.append("\n");
            }
            writer.flush();
        } catch(IOException ex){
            throw new GraphicException(GraphicErrorCode.WRONG_FILE, ex);
        }

        System.out.println("Данные отправлены в файл (закройте его вручную после просмотра, чтобы увидеть обновления): " + file);

    }
    
}
