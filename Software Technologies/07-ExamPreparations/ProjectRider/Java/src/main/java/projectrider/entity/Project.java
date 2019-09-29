package projectrider.entity;

import com.sun.javafx.geom.transform.Identity;

import javax.persistence.*;
// very important to import this library in that way!

@Entity
@Table(name = "projects")
public class Project {
   private Integer id;
   // in java we need id
   private String title;
   private String description;
   private Integer budget;


    public Project() {
        // default constructor

    }

    public Project(String title, String description, Integer budget) {
        this.title = title;
        this.description = description;
        this.budget = budget;

        //constructor without ID
    }

// we can generate anotations over the variables or on the getteries and setteries
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(name="title", nullable = false, columnDefinition = "text")
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(name="description", nullable = false, columnDefinition = "text")
    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Column(nullable = false)
    public Integer getBudget() {
        return budget;
    }

    public void setBudget(Integer budget) {
        this.budget = budget;
    }
}
