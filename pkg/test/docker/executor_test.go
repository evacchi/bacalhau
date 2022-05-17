package docker

import (
	"testing"

	_ "github.com/filecoin-project/bacalhau/pkg/logger"
)

// each of these tests will use both fuse and api copy storage drivers
// as well as stdout vs output volume mode
// so each test will be run 4 times
func TestSingleFile(t *testing.T) {

	tests := GetTestCases(t)

	for _, test := range tests {

		for i := 1; i < 100; i++ {
			DockerExecutorStorageTest(
				t,
				test.Name,
				test.SetupStorage,
				test.ResultsChecker,
				test.GetJobSpec,
				1,
			)
		}

	}
}
