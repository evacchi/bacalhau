/*
 * Bacalhau API
 * This page is the reference of the Bacalhau REST API. Project docs are available at https://docs.bacalhau.org/. Find more information about Bacalhau at https://github.com/filecoin-project/bacalhau.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: team@bacalhau.org
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.ModelStorageSpec;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ModelPublishedResult
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2022-11-25T18:06:36.734351Z[Europe/London]")
public class ModelPublishedResult {
  @SerializedName("Data")
  private ModelStorageSpec data = null;

  @SerializedName("NodeID")
  private String nodeID = null;

  @SerializedName("ShardIndex")
  private Integer shardIndex = null;

  public ModelPublishedResult data(ModelStorageSpec data) {
    this.data = data;
    return this;
  }

   /**
   * Get data
   * @return data
  **/
  @Schema(description = "")
  public ModelStorageSpec getData() {
    return data;
  }

  public void setData(ModelStorageSpec data) {
    this.data = data;
  }

  public ModelPublishedResult nodeID(String nodeID) {
    this.nodeID = nodeID;
    return this;
  }

   /**
   * Get nodeID
   * @return nodeID
  **/
  @Schema(description = "")
  public String getNodeID() {
    return nodeID;
  }

  public void setNodeID(String nodeID) {
    this.nodeID = nodeID;
  }

  public ModelPublishedResult shardIndex(Integer shardIndex) {
    this.shardIndex = shardIndex;
    return this;
  }

   /**
   * Get shardIndex
   * @return shardIndex
  **/
  @Schema(description = "")
  public Integer getShardIndex() {
    return shardIndex;
  }

  public void setShardIndex(Integer shardIndex) {
    this.shardIndex = shardIndex;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ModelPublishedResult modelPublishedResult = (ModelPublishedResult) o;
    return Objects.equals(this.data, modelPublishedResult.data) &&
        Objects.equals(this.nodeID, modelPublishedResult.nodeID) &&
        Objects.equals(this.shardIndex, modelPublishedResult.shardIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(data, nodeID, shardIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModelPublishedResult {\n");
    
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    nodeID: ").append(toIndentedString(nodeID)).append("\n");
    sb.append("    shardIndex: ").append(toIndentedString(shardIndex)).append("\n");
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
