package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.v3.oas.annotations.media.Schema;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * ModelStorageSpec
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2022-11-25T18:06:37.098869Z[Europe/London]")


public class ModelStorageSpec   {
  @JsonProperty("CID")
  private String CID = null;

  @JsonProperty("Metadata")
  @Valid
  private Map<String, String> metadata = null;

  @JsonProperty("Name")
  private String name = null;

  @JsonProperty("StorageSource")
  private Integer storageSource = null;

  @JsonProperty("URL")
  private String URL = null;

  @JsonProperty("path")
  private String path = null;

  public ModelStorageSpec CID(String CID) {
    this.CID = CID;
    return this;
  }

  /**
   * The unique ID of the data, where it makes sense (for example, in an IPFS storage spec this will be the data's CID). NOTE: The below is capitalized to match IPFS & IPLD (even though it's out of golang fmt)
   * @return CID
   **/
  @Schema(example = "QmTVmC7JBD2ES2qGPqBNVWnX1KeEPNrPGb7rJ8cpFgtefe", description = "The unique ID of the data, where it makes sense (for example, in an IPFS storage spec this will be the data's CID). NOTE: The below is capitalized to match IPFS & IPLD (even though it's out of golang fmt)")
  
    public String getCID() {
    return CID;
  }

  public void setCID(String CID) {
    this.CID = CID;
  }

  public ModelStorageSpec metadata(Map<String, String> metadata) {
    this.metadata = metadata;
    return this;
  }

  public ModelStorageSpec putMetadataItem(String key, String metadataItem) {
    if (this.metadata == null) {
      this.metadata = new HashMap<String, String>();
    }
    this.metadata.put(key, metadataItem);
    return this;
  }

  /**
   * Additional properties specific to each driver
   * @return metadata
   **/
  @Schema(description = "Additional properties specific to each driver")
  
    public Map<String, String> getMetadata() {
    return metadata;
  }

  public void setMetadata(Map<String, String> metadata) {
    this.metadata = metadata;
  }

  public ModelStorageSpec name(String name) {
    this.name = name;
    return this;
  }

  /**
   * Name of the spec's data, for reference.
   * @return name
   **/
  @Schema(example = "job-9304c616-291f-41ad-b862-54e133c0149e-shard-0-host-QmdZQ7ZbhnvWY1J12XYKGHApJ6aufKyLNSvf8jZBrBaAVL", description = "Name of the spec's data, for reference.")
  
    public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public ModelStorageSpec storageSource(Integer storageSource) {
    this.storageSource = storageSource;
    return this;
  }

  /**
   * StorageSource is the abstract source of the data. E.g. a storage source might be a URL download, but doesn't specify how the execution engine does the download or what it will do with the downloaded data.
   * @return storageSource
   **/
  @Schema(description = "StorageSource is the abstract source of the data. E.g. a storage source might be a URL download, but doesn't specify how the execution engine does the download or what it will do with the downloaded data.")
  
    public Integer getStorageSource() {
    return storageSource;
  }

  public void setStorageSource(Integer storageSource) {
    this.storageSource = storageSource;
  }

  public ModelStorageSpec URL(String URL) {
    this.URL = URL;
    return this;
  }

  /**
   * Source URL of the data
   * @return URL
   **/
  @Schema(description = "Source URL of the data")
  
    public String getURL() {
    return URL;
  }

  public void setURL(String URL) {
    this.URL = URL;
  }

  public ModelStorageSpec path(String path) {
    this.path = path;
    return this;
  }

  /**
   * The path that the spec's data should be mounted on, where it makes sense (for example, in a Docker storage spec this will be a filesystem path). TODO: #668 Replace with \"Path\" (note the caps) for yaml/json when we update the n.js file
   * @return path
   **/
  @Schema(description = "The path that the spec's data should be mounted on, where it makes sense (for example, in a Docker storage spec this will be a filesystem path). TODO: #668 Replace with \"Path\" (note the caps) for yaml/json when we update the n.js file")
  
    public String getPath() {
    return path;
  }

  public void setPath(String path) {
    this.path = path;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ModelStorageSpec modelStorageSpec = (ModelStorageSpec) o;
    return Objects.equals(this.CID, modelStorageSpec.CID) &&
        Objects.equals(this.metadata, modelStorageSpec.metadata) &&
        Objects.equals(this.name, modelStorageSpec.name) &&
        Objects.equals(this.storageSource, modelStorageSpec.storageSource) &&
        Objects.equals(this.URL, modelStorageSpec.URL) &&
        Objects.equals(this.path, modelStorageSpec.path);
  }

  @Override
  public int hashCode() {
    return Objects.hash(CID, metadata, name, storageSource, URL, path);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModelStorageSpec {\n");
    
    sb.append("    CID: ").append(toIndentedString(CID)).append("\n");
    sb.append("    metadata: ").append(toIndentedString(metadata)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    storageSource: ").append(toIndentedString(storageSource)).append("\n");
    sb.append("    URL: ").append(toIndentedString(URL)).append("\n");
    sb.append("    path: ").append(toIndentedString(path)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}
