package Seminar1;

import java.util.List;

public class ModelStore {
    private List<Scene> scenes;
    private List<PoligonalModel> models;
    private List<Camera> cameras;
    private List<Flash> flashes;

    /**
     * Магазин моделей. Загружается, например, из БД.
     * @param scenes
     * @param models
     * @param cameras
     * @param flashes
     */    
    public ModelStore() { // композиция из моделей и сцен
        // TODO здесь модели и сцены загружаются из БД, например.
        // заполняют соответствующие списки.
    }

    /**
     * Получение сцены по заданному id из магазина. 
     * @param id
     * @return экземпляр Scene с id
     */
    public Scene getScene(int id) {
        return scenes.get(id);
    }

    /**
     * Получение модели по заданному id из магазина. 
     * @param type
     * @param id
     * @return экземпляр наследника Model с id
     */
    public Model getModel(ModelType type, int id) {
        switch (type) {
            case POLIGONAL_MODEL:
                return models.get(id);
            case CAMERA:
                return cameras.get(id);
            case FLASH:
                return flashes.get(id);
                
            default:
                return null;
        }        
    }

}
