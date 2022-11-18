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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ModelBuildVersionInfo
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2022-11-25T18:06:36.734351Z[Europe/London]")
public class ModelBuildVersionInfo {
  @SerializedName("builddate")
  private String builddate = null;

  @SerializedName("gitcommit")
  private String gitcommit = null;

  @SerializedName("gitversion")
  private String gitversion = null;

  @SerializedName("goarch")
  private String goarch = null;

  @SerializedName("goos")
  private String goos = null;

  @SerializedName("major")
  private String major = null;

  @SerializedName("minor")
  private String minor = null;

  public ModelBuildVersionInfo builddate(String builddate) {
    this.builddate = builddate;
    return this;
  }

   /**
   * Get builddate
   * @return builddate
  **/
  @Schema(example = "2022-11-16T14:03:31Z", description = "")
  public String getBuilddate() {
    return builddate;
  }

  public void setBuilddate(String builddate) {
    this.builddate = builddate;
  }

  public ModelBuildVersionInfo gitcommit(String gitcommit) {
    this.gitcommit = gitcommit;
    return this;
  }

   /**
   * Get gitcommit
   * @return gitcommit
  **/
  @Schema(example = "d612b63108f2b5ce1ab2b9e02444eb1dac1d922d", description = "")
  public String getGitcommit() {
    return gitcommit;
  }

  public void setGitcommit(String gitcommit) {
    this.gitcommit = gitcommit;
  }

  public ModelBuildVersionInfo gitversion(String gitversion) {
    this.gitversion = gitversion;
    return this;
  }

   /**
   * Get gitversion
   * @return gitversion
  **/
  @Schema(example = "v0.3.12", description = "")
  public String getGitversion() {
    return gitversion;
  }

  public void setGitversion(String gitversion) {
    this.gitversion = gitversion;
  }

  public ModelBuildVersionInfo goarch(String goarch) {
    this.goarch = goarch;
    return this;
  }

   /**
   * Get goarch
   * @return goarch
  **/
  @Schema(example = "amd64", description = "")
  public String getGoarch() {
    return goarch;
  }

  public void setGoarch(String goarch) {
    this.goarch = goarch;
  }

  public ModelBuildVersionInfo goos(String goos) {
    this.goos = goos;
    return this;
  }

   /**
   * Get goos
   * @return goos
  **/
  @Schema(example = "linux", description = "")
  public String getGoos() {
    return goos;
  }

  public void setGoos(String goos) {
    this.goos = goos;
  }

  public ModelBuildVersionInfo major(String major) {
    this.major = major;
    return this;
  }

   /**
   * Get major
   * @return major
  **/
  @Schema(example = "0", description = "")
  public String getMajor() {
    return major;
  }

  public void setMajor(String major) {
    this.major = major;
  }

  public ModelBuildVersionInfo minor(String minor) {
    this.minor = minor;
    return this;
  }

   /**
   * Get minor
   * @return minor
  **/
  @Schema(example = "3", description = "")
  public String getMinor() {
    return minor;
  }

  public void setMinor(String minor) {
    this.minor = minor;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ModelBuildVersionInfo modelBuildVersionInfo = (ModelBuildVersionInfo) o;
    return Objects.equals(this.builddate, modelBuildVersionInfo.builddate) &&
        Objects.equals(this.gitcommit, modelBuildVersionInfo.gitcommit) &&
        Objects.equals(this.gitversion, modelBuildVersionInfo.gitversion) &&
        Objects.equals(this.goarch, modelBuildVersionInfo.goarch) &&
        Objects.equals(this.goos, modelBuildVersionInfo.goos) &&
        Objects.equals(this.major, modelBuildVersionInfo.major) &&
        Objects.equals(this.minor, modelBuildVersionInfo.minor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(builddate, gitcommit, gitversion, goarch, goos, major, minor);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModelBuildVersionInfo {\n");
    
    sb.append("    builddate: ").append(toIndentedString(builddate)).append("\n");
    sb.append("    gitcommit: ").append(toIndentedString(gitcommit)).append("\n");
    sb.append("    gitversion: ").append(toIndentedString(gitversion)).append("\n");
    sb.append("    goarch: ").append(toIndentedString(goarch)).append("\n");
    sb.append("    goos: ").append(toIndentedString(goos)).append("\n");
    sb.append("    major: ").append(toIndentedString(major)).append("\n");
    sb.append("    minor: ").append(toIndentedString(minor)).append("\n");
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
