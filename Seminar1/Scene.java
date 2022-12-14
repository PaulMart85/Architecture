package Seminar1;

import java.util.List;

public class Scene {
    private int id;
    private int width;
    private int height;
    private List<PoligonalModel> models;
    private List<Camera> cameras;
    private List<Flash> flashes;

    public Scene(int id, int width, int height) {
        this.id = id;
        this.width = width;
        this.height = height;
    }

    public Scene(int id, int width, int height, List<PoligonalModel> models, List<Camera> cameras, List<Flash> flashes) {
        this(id, width, height);
        this.models = models;
        this.cameras = cameras;
        this.flashes = flashes;
    }

    /**
     * Добавление модели на сцену.
     * @param model
     * @return id добавленной модели
     */
    public int addModel(Model model) {
        switch (model.getClass().getSimpleName()) {
            case "PoligonalModel":
                models.add((PoligonalModel) model);
                return models.indexOf(model);
            case "Camera":
                cameras.add((Camera) model);
                return cameras.indexOf(model);
            case "Flash":
                flashes.add((Flash) model);
                return flashes.indexOf(model);
                
            default:
                return -1;
        }        
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public List<PoligonalModel> getModels() {
        return models;
    }

    public void setModels(List<PoligonalModel> models) {
        this.models = models;
    }

    public List<Camera> getCameras() {
        return cameras;
    }

    public void setCameras(List<Camera> cameras) {
        this.cameras = cameras;
    }

    public List<Flash> getFlashes() {
        return flashes;
    }

    public void setFlashes(List<Flash> flashes) {
        this.flashes = flashes;
    }


}
