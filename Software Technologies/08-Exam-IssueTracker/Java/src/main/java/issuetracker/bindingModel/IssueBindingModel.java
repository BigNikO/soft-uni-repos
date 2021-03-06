package issuetracker.bindingModel;

import javax.validation.constraints.NotNull;

public class IssueBindingModel {

    @NotNull
    private String title;

    @NotNull
    private String content;

    @NotNull
    private Integer priority;

    @NotNull
    public String getTitle() {
        return title;
    }

    public void setTitle(@NotNull String title) {
        this.title = title;
    }

    @NotNull
    public String getContent() {
        return content;
    }

    public void setContent(@NotNull String content) {
        this.content = content;
    }

    @NotNull
    public Integer getPriority() {
        return priority;
    }

    public void setPriority(@NotNull Integer priority) {
        this.priority = priority;
    }
}
