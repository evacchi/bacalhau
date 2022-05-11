package ipfs

import (
	"fmt"
	"testing"

	"context"
	"time"

	"github.com/filecoin-project/bacalhau/pkg/devstack"
	_ "github.com/filecoin-project/bacalhau/pkg/logger"
	"github.com/filecoin-project/bacalhau/pkg/system"
	"github.com/stretchr/testify/assert"

	"github.com/rs/zerolog/log"
)

func SetupTest(
	t *testing.T,
	nodes int,
) (*devstack.DevStack_IPFS, context.CancelFunc) {
	ctx, cancelFunction := system.GetCancelContext()

	stack, err := devstack.NewDevStack_IPFS(
		ctx,
		nodes,
	)
	assert.NoError(t, err)
	if err != nil {
		log.Fatal().Msg(fmt.Sprintf("Unable to create devstack: %s", err))
	}
	// TODO: add a waitgroup with checks on each part of a node
	// (i.e. libp2p connected, jsonrpc serving, ipfs functional)
	time.Sleep(time.Second * 2)
	return stack, cancelFunction
}

func TeardownTest(stack *devstack.DevStack_IPFS, cancelFunction context.CancelFunc) {
	if !system.ShouldKeepStack() {
		cancelFunction()
		// need some time to let ipfs processes shut down
		time.Sleep(time.Second * 2)
	} else {
		stack.PrintNodeInfo()
		system.ClearKeepStack()
		select {}
	}
}
